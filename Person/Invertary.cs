using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronKiller
{
    public class Invertary
    {
        const int size_invrt = 30;
        Item[] items;
        int last_choise=0;
        void Add(Item it)
        {
            items[last_choise] = it;
            last_choise++;
        }
        void remove(int i)
        {
            last_choise--; 
            for(int j = i-1;j< last_choise; j++)
                items[j] = items[j + 1];
        }
        public Invertary()
        {
            items = new Item[size_invrt];
        }
    }
}
