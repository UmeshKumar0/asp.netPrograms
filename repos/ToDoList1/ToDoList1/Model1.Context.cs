//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoList1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TodoListEntities10 : DbContext
    {
        public TodoListEntities10()
            : base("name=TodoListEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ListData> ListDatas { get; set; }
    
        public virtual ObjectResult<ListData1_Result> ListData1(string action, Nullable<int> iD, string title, Nullable<int> timeSpend, Nullable<System.DateTime> createdAt)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var timeSpendParameter = timeSpend.HasValue ?
                new ObjectParameter("TimeSpend", timeSpend) :
                new ObjectParameter("TimeSpend", typeof(int));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListData1_Result>("ListData1", actionParameter, iDParameter, titleParameter, timeSpendParameter, createdAtParameter);
        }
        public virtual ObjectResult<ListData> DataCRUD(string action, Nullable<int> iD, string title, Nullable<int> timeSpend, Nullable<System.DateTime> createdAt)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));

            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));

            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));

            var timeSpendParameter = timeSpend.HasValue ?
                new ObjectParameter("TimeSpend", timeSpend) :
                new ObjectParameter("TimeSpend", typeof(int));

            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListData>("ListData1", actionParameter, iDParameter, titleParameter, timeSpendParameter, createdAtParameter);
        }

        public virtual ObjectResult<ListData> DataCRUD(string action, Nullable<int> iD, string title, Nullable<int> timeSpend, Nullable<System.DateTime> createdAt, MergeOption mergeOption)
        {
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));

            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));

            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));

            var timeSpendParameter = timeSpend.HasValue ?
                new ObjectParameter("TimeSpend", timeSpend) :
                new ObjectParameter("TimeSpend", typeof(int));

            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListData>("ListData1", mergeOption, actionParameter, iDParameter, titleParameter, timeSpendParameter, createdAtParameter);
        }
    }
}
