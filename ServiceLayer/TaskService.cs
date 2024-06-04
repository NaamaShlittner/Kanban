using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
	public class BoardService
	{
		public Response EditTask(string email,long boardID, string dueDate, string title, string desc){
			throw new NotImplementedException("TODO");
		}
		public Response CreateTask(string userEmail, string dueDate, string title, string desc){
			throw new NotImplementedException("TODO");
		}
		public Response MoveTask(string userEmail, long boardID, long taskID, int columnNum){
			throw new NotImplementedException("TODO");
		}
        public Response GetAllInProgress(string userEmail){
			throw new NotImplementedException("TODO");
		}
	}
}