using Packt.Shared;

Person bob = new(); // C# 9.0 or later
bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
WriteLine(format: "{0} was born on {1:dddd, d MMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine(
format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
arg0: bob.Name,
arg1: bob.FavoriteAncientWonder,
arg2: (int)bob.FavoriteAncientWonder);

bob.BucketList =
WondersOfTheAncientWorld.HangingGardensOfBabylon
| WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
