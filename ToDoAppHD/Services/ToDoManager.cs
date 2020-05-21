using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPP.Contracts;
using ToDoAppHD.Models;

namespace ToDoAppHD.Services
{
    public class ToDoManager : IToDoManager
    {
        private readonly IDapperManager _dapperManager;

        public ToDoManager(IDapperManager dapperManager)
        {
            this._dapperManager = dapperManager;
        }

        public Task<int> Create(ToDo toDo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Title", toDo.Title, DbType.String);
            dbPara.Add("Description", toDo.Description, DbType.String);
            dbPara.Add("Date", toDo.Date, DbType.DateTime);
            dbPara.Add("Priority", toDo.Priority, DbType.String);
            dbPara.Add("Status", toDo.Status, DbType.String);
            var articleId = Task.FromResult(_dapperManager.Insert<int>("[dbo].[SP_Add_ToDo]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return articleId;
        }

        public Task<ToDo> GetById(int id)
        {
            var article = Task.FromResult(_dapperManager.Get<ToDo>($"select * from [ToDo] where ID = {id}", null,
                    commandType: CommandType.Text));
            return article;
        }

        public Task<int> Delete(int id)
        {
            var deleteArticle = Task.FromResult(_dapperManager.Execute($"Delete [ToDo] where ID = {id}", null,
                    commandType: CommandType.Text));
            return deleteArticle;
        }

        public Task<int> Count(string search)
        {
            var totArticle = Task.FromResult(_dapperManager.Get<int>($"select COUNT(*) from [ToDo] WHERE Title like '%{search}%'", null,
                    commandType: CommandType.Text));
            return totArticle;
        }

        public Task<List<ToDo>> ListAll()
        {
            var articles = Task.FromResult(_dapperManager.GetAll<ToDo>
                ($"SELECT * FROM [ToDo]; ", null, commandType: CommandType.Text));
            return articles;
        }

        public Task<int> Update(ToDo toDo)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", toDo.ID);
            dbPara.Add("Title", toDo.Title, DbType.String);
            dbPara.Add("Description", toDo.Description, DbType.String);
            dbPara.Add("Date", toDo.Date, DbType.DateTime);
            dbPara.Add("Priority", toDo.Priority, DbType.String);
            dbPara.Add("Status", toDo.Status, DbType.String);

            var updateArticle = Task.FromResult(_dapperManager.Update<int>("[dbo].[SP_Update_ToDo]",
                            dbPara,
                            commandType: CommandType.StoredProcedure));
            return updateArticle;
        }

    }
}
