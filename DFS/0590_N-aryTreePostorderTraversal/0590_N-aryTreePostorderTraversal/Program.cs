/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        var result = new List<int>();
        if(root == null) return result;

        DFS(root, result);
        
        return result;
    }
    
    private void DFS(Node node, List<int> result)
    {
        if(node.children == null) return;
        
        foreach(var child in node.children)
        {
            DFS(child, result);
        }
        result.Add(node.val);
    }
}