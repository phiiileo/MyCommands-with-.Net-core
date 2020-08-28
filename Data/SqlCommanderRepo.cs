
using System;
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

        public void createCommand(Command cmd)
        {
            if(cmd == null){
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.commands.FirstOrDefault(p => p.Id == id);
        }

        public bool saveChanges()
        {
            return _context.SaveChanges() >= 0;

        }
    }
}