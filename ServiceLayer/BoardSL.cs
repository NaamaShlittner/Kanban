using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
	public class BoardSL
	{
        public long BoardID;
        public string BoardName;
        public Dictionary<long,TaskSL> backlog;
        public Dictionary<long,TaskSL> inProgress; 
        public Dictionary<long,TaskSL> done;

	}
}