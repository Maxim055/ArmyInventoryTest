using Data.Dbcontext;
using Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;

namespace ArmyInventory.Services

{

    public class InventoryRepository
    {
        private readonly InventoryContext _context ;


        public InventoryRepository()
        {
             
            _context = new InventoryContext();
        }

        
        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories.ToList<Category>();
        }
        public async Task<Result> AddCategoryAsync (string NewCategoryName)
        {
            if (NewCategoryName == null)
            {
                return Result.Fail("");
            }
            var   item = _context.Categories.FirstOrDefaultAsync(x => x.Categoryname == NewCategoryName);        
            
            try
            {
                if (item == null)
                {
                    var t = new Category()
                    {
                        Categoryname = NewCategoryName
                        
                    };
                    await _context.Categories.AddAsync(t);
                    await _context.SaveChangesAsync();  
                    return Result.Ok();
            }
               return Result.Ok();
            }
            catch (Exception ex)
            {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
                return Result.Fail(ex.Message);
            }
            
        }
      
       
    }
}
