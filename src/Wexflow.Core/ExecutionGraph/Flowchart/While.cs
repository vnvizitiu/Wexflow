﻿using System.Collections.Generic;
using System.Linq;

namespace Wexflow.Core.ExecutionGraph.Flowchart
{
    public class While: Node
    {
        public int WhileId { get; }
        public Node[] Nodes { get; }

        public While(int id, int parentId, int whileId, IEnumerable<Node> nodes):base(id, parentId)
        {
            WhileId = whileId;
            if (nodes != null) Nodes = nodes.ToArray();
        }
    }
}
