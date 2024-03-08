// example


using UnityEngine;
using System.IO;
using System.Text;

void FileExample(string serizliedData)
{
   var raws = Encoding.UTF8.GetBytes(serizliedData);
   FileExample(raws);
}

void FileExample(byte[] serizliedData)
{
   const string fileName = "gamesave.dat";
   var filePath = Application.persistentDataPath + "/" + fileName;

   // Save
   try
   {
      File.WriteAllBytes(filePath, serizliedData);
   }
   catch (System.Exception e)
   {
      // TODO: Handle exception
   }

   // Load
   try
   {
      serizliedData = File.ReadAllBytes(filePath);
   }
   catch (System.Exception e)
   {
      // TODO: Handle exception
   }
}



// Using JSON format to read and Save file


public static void Save(object gameState, string fileName = "gamesave.dat")
{
   var serializedData = JsonUtility.ToJson(gameState);
   var filePath = Application.persistentDataPath + "/" + fileName;
   File.WriteAllBytes(filePath, serizliedData);
}

public static T Load<T>(string fileName = "gamesave.dat")
{
   var filePath = Application.persistentDataPath + "/" + fileName;
   var serizliedData = ([]byte)(null)
   try
   {
      serizliedData = File.ReadAllBytes(filePath);
   }
   catch (System.IO.FileNotFoundException)
   {
      return null;
   }
   return JsonUtility.FromJson<T>(serializedData);
}

