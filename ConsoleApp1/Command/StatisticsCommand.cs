using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Command
{
    public class StatisticsCommand : Command
    {
        public void execute()
        {
            BookStatistics stats = new BookStatistics();
            DocumentManager.getInstance().getBook().accept(stats);
            stats.printStatistics();
        }
    }
}
