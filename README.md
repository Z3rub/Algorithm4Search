# Algorithm4Search
Breadth-first, depth-first and uniform-cost search Algorithms by C#

* Breadth-First Search
All the nodes reachable from the current node are explored
first (shallow nodes are expanded before deep nodes).
Algorithm (Informal)
1. Enqueue the root/initial node.
2. Dequeue a node and examine it.
1. If the element sought is found in this node, quit the search and return a
result.
2. Otherwise enqueue any successors (the direct child nodes) that have not
yet been discovered.
3. If the queue is empty, every node on the graph has been examined –
quit the search and return "not found".
4. Repeat from Step 2.

* Uniform-Cost -First
Visits the next node which has the least total cost from the
root, until a goal state is reached.
1. Similar to BREADTH-FIRST, but with an evaluation of the cost for
each reachable node.
2. g(n) = path cost(n) = sum of individual edge costs to reach the
current node.

* Depth-First Search
- A depth-first search (DFS) explores a path all the way to a leaf before backtracking and exploring another path.
- For example, after searching A, then B, then D, the search backtracks and tries another path from B.
- Node are explored in the order A B D E H L M N I O P C F G J K Q

