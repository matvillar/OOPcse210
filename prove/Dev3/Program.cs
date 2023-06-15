// See https://aka.ms/new-console-template for more information

Reference newReference = new Reference("John", 3, 16, 17);
Console.WriteLine(newReference.StringifyRef());

Scripture newScripture = new Scripture(newReference);
newScripture.AddWordsToCreateScripture();