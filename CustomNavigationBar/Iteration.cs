var priorities = Enum.GetValues(typeof(Models.Priority)).OfType<Models.Priority>().ToList();

for (int i = priorities.Count - 1; i >= 0; i--)
{
    Models.Priority priority = priorities[i];
    prioritiesDictionary.Add((int)priority, "Priority " + ((int)priority).ToString());
}