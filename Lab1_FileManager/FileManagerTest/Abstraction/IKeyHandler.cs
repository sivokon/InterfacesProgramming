using FileManagerTest.Models;

namespace FileManagerTest.Abstraction
{
    public interface IKeyHandler
    {
        void HandlePressedKey(FileManagerState fileManagerState);
    }
}
