using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoApp.Services
{
    internal class FileIOService
    {
        private readonly string PATH;

        public FileIOService(string path)
        {
            PATH = path;
        }
        public BindingList<TodoModel> LoadData() {
            return null;
        }

        public void SaveData(BindingList<TodoModel> todoDataList)
        {
            
        }
    }
}
