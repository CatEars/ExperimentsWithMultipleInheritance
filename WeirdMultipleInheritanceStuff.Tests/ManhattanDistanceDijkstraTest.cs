using System.Collections.Generic;
using System.Linq;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;
using WeirdMultipleInheritanceStuff.Combiners;
using Xunit;

namespace WeirdMultipleInheritanceStuff.Tests;

public class ManhattanDistanceDijkstraTest
{
    [Fact]
    public void StraightGraph()
    {
        var nodes = new List<CoordinateNode>()
        {
            new(1, new Coordinate(0, 0)), 
            new(2, new Coordinate(1, 1)), 
            new(3, new Coordinate(2, 2))
        };
        var edges = new Dictionary<int, List<int>>()
        {
            {1, new List<int>() {2}},
            {2, new List<int>() {3}}
        };
        var graph = CreateSut(nodes, edges, out var solver);
        IShortestPathCalculator sut = solver;

        var result = sut.CalculateShortestPath(graph, nodes[0], nodes[2]);

        Assert.Equal(new List<int>() {1, 2, 3}, result.NodeOrder);
        Assert.Equal(4, result.Distance);
    }

    [Fact]
    public void MultiPathGraph_WithOneObviouslyWorsePath()
    {
        var nodes = new List<CoordinateNode>()
        {
            new(1, new Coordinate(0, 0)), 
            new(2, new Coordinate(1, 1)), 
            new(3, new Coordinate(2, 2)), 
            new(4, new Coordinate(3, 3)), 
            new(5, new Coordinate(-100, -100))
        };
        var edges = new Dictionary<int, List<int>>()
        {
            { 1, new List<int>() { 2, 5 } },
            { 2, new List<int>() { 3, 1 } },
            { 3, new List<int>() { 4, 2 } },
            { 4, new List<int>() { 5, 3 } },
            { 5, new List<int>() { 1, 4 } }
        };
        var graph = CreateSut(nodes, edges, out var solver);
        IShortestPathCalculator sut = solver;
        
        var result = sut.CalculateShortestPath(graph, nodes[0], nodes[3]);

        Assert.Equal(new List<int>() {1, 2, 3, 4}, result.NodeOrder);
        Assert.Equal(6, result.Distance);
    }
    
    
    private static Graph CreateSut(List<CoordinateNode> nodes, Dictionary<int, List<int>> edges, out ManhattanDistanceDijkstra solver)
    {
        var nodeList = nodes.Select(x => (Node) x).ToList();
        var graph = new Graph(nodeList, edges);
        solver = new ManhattanDistanceDijkstra();
        INodeRepository<CoordinateNode> repo = solver;
        repo.AddNodes(nodes);
        return graph;
    }
}