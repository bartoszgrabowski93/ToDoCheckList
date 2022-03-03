using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCheckList
{
    public class MenuAction
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string MenuName { get; set; }

        public MenuAction(): this(1, "Work")
        {

        }

        public MenuAction(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
