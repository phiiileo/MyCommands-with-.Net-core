using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool saveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        void createCommand(Command cmd);
        void updateCommand(Command cmd);
        void deleteCommand(Command cmd);
    }
}