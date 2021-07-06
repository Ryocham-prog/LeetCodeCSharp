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
        IList<int> result = new List<int>();
        if(root == null) return result;

        DFS(root, result);
        result.Add(root.val);
        
        return result;
    }
    
    private void DFS(Node node, IList<int> result)
    {
        if(node == null) return;
        
        foreach(var child in node.children)
        {
            DFS(child, result);
            result.Add(child.val);
        }
    }
}