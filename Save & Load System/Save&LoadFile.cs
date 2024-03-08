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
