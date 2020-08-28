using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void createCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void deleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           var commands = new List<Command>
           {
               new Command{Id=0, HowTo="Boil an egg", Line="Boil egg", Platform="Pot and Pan"},
               new Command{Id=1, HowTo="Kill an egg", Line="Kill egg", Platform="Pot and Pan"},
               new Command{Id=2, HowTo="Spray an egg", Line="Spray egg", Platform="Pot and Pan"},
               new Command{Id=3, HowTo="Spill an egg", Line="Spill egg", Platform="Pot and Pan"},
           };

           return commands;
        }

        public Command GetCommandById(int id)
        {
           return new Command{Id=0, HowTo="Boil an egg", Line="Boil egg", Platform="Pot and Pan"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void updateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}