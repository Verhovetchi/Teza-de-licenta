using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace Final.Models
{
     public class New
     {
          public int Id { get; set; }
          public int PictureId { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }

          public Picture picture { get; set; }
     }

     public class PageInfo
     {
          public int PageNumber { get; set; } // номер текущей страницы
          public int PageSize { get; set; } // кол-во объектов на странице
          public int TotalItems { get; set; } // всего объектов
          public int TotalPages  // всего страниц
          {
               get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
          }
     }

     public class IndexViewModel
     {
          public IEnumerable<New> News { get; set; }
          public PageInfo PageInfo { get; set; }
     }
}