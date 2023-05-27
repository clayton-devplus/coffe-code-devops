using CoffeCodeDevops.Data.Dto;
using CoffeCodeDevops.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeCodeDevops.Data.Repository
{
    public class TestTableRepository
    {
        private readonly DBDataContext _context;
        public TestTableRepository(DBDataContext context)
        {
            _context = context;
        }
        public async Task CreateReg(TestTableDto testTable)
        {
            var tt = new TestTableModel()
            {
                tableId = Guid.NewGuid().ToString(),
                tableName = testTable.tableName,
                tableType = testTable.tableType
            };

            _context.TestTable.Add(tt);
            await _context.SaveChangesAsync();
        }
        public async Task<List<TestTableModel>> GetRegs()
        {
            var tables = await _context.TestTable.ToListAsync();
            return tables;
        }
    }
}
