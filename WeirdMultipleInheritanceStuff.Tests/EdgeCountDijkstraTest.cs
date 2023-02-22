using System.Collections.Generic;
using WeirdMultipleInheritanceStuff.Algorithms.Repository;
using WeirdMultipleInheritanceStuff.Algorithms.ShortestPath;
using WeirdMultipleInheritanceStuff.Combiners;
using Xunit;

namespace WeirdMultipleInheritanceStuff.Tests;

public class EdgeCountDijkstraTest
{
    [Fact]
    public void StraightGraph()
    {
        var nodes = new List<Node>()
        {
            new(1), new(2), new(3)
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
        Assert.Equal(2, result.Distance);
    }

    [Fact]
    public void MultiPathGraph()
    {
        var nodes = new List<Node>()
        {
            new(1), new(2), new(3), new(4), new(5)
        };
        var edges = new Dictionary<int, List<int>>()
        {
            { 1, new List<int>() { 2, 5 } },
            { 2, new List<int>() { 3, 1 } },
            { 3, new List<int>() { 4, 2 } },
            { 4, new List<int>() { 5, 3 } },
            { 5, new List<int>() { 1 } }
        };
        var graph = CreateSut(nodes, edges, out var solver);
        IShortestPathCalculator sut = solver;
        
        var result = sut.CalculateShortestPath(graph, nodes[0], nodes[4]);

        Assert.Equal(new List<int>() {1, 5}, result.NodeOrder);
        Assert.Equal(1, result.Distance);
    }

    private static Graph CreateSut(List<Node> nodes, Dictionary<int, List<int>> edges, out EdgeCountDijkstra solver)
    {
        var graph = new Graph(nodes, edges);
        solver = new EdgeCountDijkstra();
        INodeRepository<Node> repo = solver;
        repo.AddNodes(nodes);
        return graph;
    }
}