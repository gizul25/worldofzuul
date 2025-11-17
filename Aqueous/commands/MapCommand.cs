using System.ComponentModel;

namespace Aqueous;

public class MapCommand : SimpleCommand
{
    public override string GetName()
    {
        return "map";
    }

    public override void Run(GameState state)
    {
        string roomName = state.CurrentRoom.GetName();
        string map = @$"
                                                       Crew Cabin --- Elevator
                                                       (Entrance)
                                                           |
                            Security                       |
                               |                           |
                               |                           |      
                      -----  Upper  ---  MedBay ----- Cafeteria --------
                      |      Engine                        |           |
                      |       |                            |           |
                      |       |                            |           |
Cooling system ----Reactor    |                        Sleeping     Primary
                      |       |                        Quarters     Research
                      |       |                            |
                      |       |                            | 
                      ----  Lower   --------- Storage---  Main --- Shields
                            Engine               |        Lab         |
                              |                  |         |          |
                              |               Delivery     |      Emergency 
                          Electrical                       |        Exit
                                                           |
                                                    Communications

";
        bool onMap = false;
        string[] mapSplit = map.Split('\n');
        string[] roomNameSplit = roomName.Split(' ');


        int first = 0;
        foreach (string str in mapSplit)
        {
            if (onMap)
            {
                break;
            }
            if (str.Contains(roomNameSplit[0]))
            {
                first = Array.IndexOf(mapSplit, str);
                for (int i = 0; i <= roomNameSplit.Length;)
                {
                    for (int j = first; j <= mapSplit.Length;)
                    {
                        if (i == roomNameSplit.Length)
                        {
                            onMap = true;
                            break;
                        }
                        else if (j == mapSplit.Length)
                        {
                            onMap = false;
                            break;
                        }
                        else if (mapSplit[j].Contains(roomNameSplit[i]))
                        {
                            i++;
                        }
                        else
                        {
                            j++;
                        }

                    }
                    break;
                }
            }
        }

        if (onMap)
        {
            int i = first;
            foreach (string word in roomNameSplit)
            {
                if (!mapSplit[i].Contains(word))
                    i++;
                mapSplit[i] = mapSplit[i].Replace(word, $"\x1b[33m{word}\x1b[0m");
            }
        }

        foreach (string str in mapSplit)
        {
            Console.WriteLine(str);
        }

    }
}