using GRM_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRM_Task.Repositories
{
    public class ItemRepository
    {
        List<Item> items = new List<Item>()
        {
            new Item() { Position = 1, Name = "Item1", Score = 0 },
            new Item() { Position = 2, Name = "Item2", Score = 0 },
            new Item() { Position = 3, Name = "Item3", Score = 0 },
            new Item() { Position = 4, Name = "Item4", Score = 0 },
            new Item() { Position = 5, Name = "Item5", Score = 0 },
            new Item() { Position = 6, Name = "Item6", Score = 0 }
        };

        List<ItemsCombination> combinations = new List<ItemsCombination>()
        {
            new ItemsCombination() { Position1 = 1, Name1 = "Item1", Score1 = 0, Position2 = 2, Name2 = "Item2", Score2 = 0 },
            new ItemsCombination() { Position1 = 1, Name1 = "Item1", Score1 = 0, Position2 = 3, Name2 = "Item3", Score2 = 0 },
            new ItemsCombination() { Position1 = 1, Name1 = "Item1", Score1 = 0, Position2 = 4, Name2 = "Item4", Score2 = 0 },
            new ItemsCombination() { Position1 = 1, Name1 = "Item1", Score1 = 0, Position2 = 5, Name2 = "Item5", Score2 = 0 },
            new ItemsCombination() { Position1 = 1, Name1 = "Item1", Score1 = 0, Position2 = 6, Name2 = "Item6", Score2 = 0 },
            new ItemsCombination() { Position1 = 2, Name1 = "Item2", Score1 = 0, Position2 = 3, Name2 = "Item3", Score2 = 0 },
            new ItemsCombination() { Position1 = 2, Name1 = "Item2", Score1 = 0, Position2 = 4, Name2 = "Item4", Score2 = 0 },
            new ItemsCombination() { Position1 = 2, Name1 = "Item2", Score1 = 0, Position2 = 5, Name2 = "Item5", Score2 = 0 },
            new ItemsCombination() { Position1 = 2, Name1 = "Item2", Score1 = 0, Position2 = 6, Name2 = "Item6", Score2 = 0 },
            new ItemsCombination() { Position1 = 3, Name1 = "Item3", Score1 = 0, Position2 = 5, Name2 = "Item5", Score2 = 0 },
            new ItemsCombination() { Position1 = 3, Name1 = "Item3", Score1 = 0, Position2 = 6, Name2 = "Item6", Score2 = 0 },
            new ItemsCombination() { Position1 = 3, Name1 = "Item3", Score1 = 0, Position2 = 4, Name2 = "Item4", Score2 = 0 },
            new ItemsCombination() { Position1 = 4, Name1 = "Item4", Score1 = 0, Position2 = 5, Name2 = "Item5", Score2 = 0 },
            new ItemsCombination() { Position1 = 4, Name1 = "Item4", Score1 = 0, Position2 = 6, Name2 = "Item6", Score2 = 0 },
            new ItemsCombination() { Position1 = 5, Name1 = "Item5", Score1 = 0, Position2 = 6, Name2 = "Item6", Score2 = 0 }
        };

        public List<Item> GetAllItems()
        {
            items = items.OrderByDescending(x => x.Score).ToList();

            int position = 0;

            foreach (var itm in items)
            {
                itm.Position = ++position;
            }

            return items;
        }

        public List<ItemsCombination> GetAllCombinations()
        {
            return combinations;
        }

        public CompareModel CompareItems(CompareModel comparedItems)
        {
            if (comparedItems != null)
            {
                if (comparedItems.Value1.GetType() == typeof(int) &&
                comparedItems.Value2.GetType() == typeof(int))
                {
                    if (combinations.Count() == 0)
                    {
                        return GetNextCombination();
                    }
                    else
                    {
                        int indexOfCombination = 0;
                        bool founded = false;
                        for (int i = 0; i < combinations.Count(); i++)
                        {
                            if (String.Equals(combinations[i].Name1, comparedItems.Name1) &&
                                String.Equals(combinations[i].Name2, comparedItems.Name2))
                            {
                                indexOfCombination = i;
                                founded = true;
                                Item item = new Item();

                                if (comparedItems.Value1 > comparedItems.Value2)
                                {
                                    //item.Score = comparedItems.Score1;
                                    item.Name = comparedItems.Name1;
                                    //item.Position = comparedItems.Position1;
                                    var indexOfItem = items.FindIndex(x => x.Name == item.Name);
                                    //item.Score++;
                                    items[indexOfItem].Score++;
                                }
                                else if (comparedItems.Value1 < comparedItems.Value2)
                                {
                                    //item.Score = comparedItems.Score2;
                                    item.Name = comparedItems.Name2;
                                    //item.Position = comparedItems.Position2;
                                    var indexOfItem = items.FindIndex(x => x.Name == item.Name);
                                    //item.Score++;
                                    items[indexOfItem].Score++;

                                }
                                else
                                {
                                    return GetNextCombination();
                                }

                                items = items.OrderByDescending(x => x.Score).ToList();

                                int position = 0;

                                foreach (var itm in items)
                                {
                                    itm.Position = ++position;
                                }

                                break;
                            }
                        }
                        if (founded)
                        {
                            combinations.RemoveAt(indexOfCombination);
                        }
                    }
                }
                return GetNextCombination();
            }
            else
            {
                return GetNextCombination();
            }
        }

        public CompareModel GetNextCombination()
        {
            if (combinations.Count() > 0)
            {
                //ItemsCombination itemCombination = new ItemsCombination();
                CompareModel compareModel = new CompareModel();

                Random random = new Random();
                int indexComaringItems = random.Next(0, combinations.Count() - 1);

                compareModel.Name1 = combinations[indexComaringItems].Name1;
                compareModel.Name2 = combinations[indexComaringItems].Name2;
                compareModel.Position1 = combinations[indexComaringItems].Position1;
                compareModel.Position2 = combinations[indexComaringItems].Position2;
                compareModel.Score1 = combinations[indexComaringItems].Score1;
                compareModel.Score2 = combinations[indexComaringItems].Score2;

                return compareModel;
            }

            return new CompareModel
            {
                Name1 = "No name",
                Name2 = "No name",
                Position1 = 0,
                Position2 = 0,
                Score1 = 0,
                Score2 = 0
            };
        }
    }
}
