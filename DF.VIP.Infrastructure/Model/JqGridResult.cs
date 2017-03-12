using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DF.VIP.Infrastructure.Model
{
   public  class JqGridResult<TItem>
    {
      
        public JqGridResult(int pagesize, int pagenum, int totalRecords, List<TItem> rows)
        {
            this.pagenum = pagenum;
            this.totalRecords = totalRecords;
            this.pagesize = pagesize;
            this.Rows = rows;
        }
        int pagenum;
        int pagesize;
        int totalRecords;
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total")]
        public int TotalPage { get {

                return (this.totalRecords + this.pagesize - 1) / this.pagesize;
            }
        }
        [JsonProperty("page")]
        public int CurrentPage { get => pagenum; private set => pagenum = value; }
        [JsonProperty("records")]
        public int TotalRecords { get => totalRecords; private set => totalRecords = value; }

        [JsonProperty("rows")]
        public List<TItem> Rows { get; private set; }
    }
}
