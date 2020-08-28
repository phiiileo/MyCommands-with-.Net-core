
using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.commands.FirstOrDefault(p => p.Id == id);
        }
    }
}