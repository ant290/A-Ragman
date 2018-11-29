# A-Ragman

Write a console application to filter a data set and display rows on screen that meet a criteria.

The criteria is that thetwo words in each row of the data set are anagrams of each other.

this must include unit testing
this must be extensible
this must take into account that the data set could come from anywhere


sample data set
leap, pale
paws, swap
wasp, shop


My plan.

start by just having a list of word pairs that get produced.
this should have a hard coded list that gets pulled into life.
this list should be a List<WordPair> which could arrive from anywhere.

With this word pair I will then iterate the list.

Each iteration will ask a helper class to determine if they are anagrams.

I can then unit test the helper class IsAnagram(String,String) method.