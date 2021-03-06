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

// 最初に思いついた方法(412 ms)
public class Solution {
    public int MaxDepth(Node root) {
        var result = 0;
        if(root == null) return result;

        DFS(root, 0, ref result);
        
        return result;
    }
    
    private void DFS(Node node, int tmp, ref int result){
        if(node == null) return;
        tmp++;
        
        if(node.children.Count == 0 && tmp > result){
            result = tmp;
            return;
        }
        
        foreach(var child in node.children){
            DFS(child, tmp, ref result);
        }
    }
}

// MaxDepthを使う方法もある模様(332 ms)
public class Solution {
    public int MaxDepth(Node root) {
        if (root == null)
        {
            return 0;
        }
        
        int depth = 0;

        foreach (var child in root.children)
        {
            depth = Math.Max(depth, MaxDepth(child));
        }
        
        return depth + 1;
    }
}

// Linq使用(404 ms)
public class Solution {
    public int MaxDepth(Node root) {
        if (root == null)
        {
            return 0;
        }
        
        var depth = root.children
            .Aggregate(0, (depthCount, child) => {
                return Math.Max(depthCount, MaxDepth(child));
            });
       
        return depth + 1;
    }
}