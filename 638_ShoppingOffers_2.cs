    public class Solution
    {
        public IList<int> prices;

        public IList<IList<int>> specialOffers;

        public int ShoppingOffers(IList<int> price, IList<IList<int>> special, IList<int> need)
        {
            // filter out the special offers that are too big
            prices = price;
            specialOffers = special;

            for (int i = 0; i < need.Count(); i++)
            {
                //specialOffers = specialOffers.Where(list => list[i] <= need[i]).ToList();   
            }

            return MinmumCost(need);
        }

        public int MinmumCost(IList<int> need)
        {
            int NoSpecial = need.Zip(prices, (x, y) => x * y).Sum();
            if (NoSpecial == 0)
            {
                return NoSpecial;
            }

            List<int> ModifiedNeed = need.Take(need.Count()).ToList();            
            

            var MinCost = 100000;
            foreach(var specialOffer in specialOffers)
            {
                List<int> NeedWithOffer = ModifiedNeed.Zip(specialOffer, (x, y) => x - y).ToList();
                List<int> SpecialOffer = specialOffer.Take(need.Count()).ToList();
                int appliedOffer = 100000;
                if (!NeedWithOffer.Exists(qty => qty != 0))
                {
                    return specialOffer.Last();
                }
                else if (!NeedWithOffer.Exists(qty => qty < 0))
                {
                    appliedOffer = MinmumCost(NeedWithOffer) + specialOffer.Last();
                }
                MinCost= Math.Min(MinCost,appliedOffer);
            }

            //int notApplied = MinmumCost(ModifiedNeed);

            return Math.Min(MinCost, NoSpecial);
        }
    }