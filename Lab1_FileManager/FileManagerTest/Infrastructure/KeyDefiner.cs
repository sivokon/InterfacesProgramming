using FileManagerTest.Abstraction;
using FileManagerTest.KeyHandlers;
using System;

namespace FileManagerTest.Infrastructure
{
    public class KeyDefiner
    {
        private Lazy<UpArrowHandler> _upArrowHandler;
        private Lazy<DownArrowHandler> _downArrowHandler;
        private Lazy<LeftArrowHandler> _leftArrowHandler;
        private Lazy<RightArrowHandler> _rightArrowHandler;
        private Lazy<AltCHandler> _altCHandler;
        private Lazy<AltVHandler> _altVHandler;
        private Lazy<AltXHandler> _altXHandler;
        private Lazy<AltIHandler> _altIHandler;
        private Lazy<DeleteHandler> _deleteHandler;
        private Lazy<DefaultHandler> _defaultHandler;

        public KeyDefiner()
        {
            _upArrowHandler = new Lazy<UpArrowHandler>(() => new UpArrowHandler());
            _downArrowHandler = new Lazy<DownArrowHandler>(() => new DownArrowHandler());
            _leftArrowHandler = new Lazy<LeftArrowHandler>(() => new LeftArrowHandler());
            _rightArrowHandler = new Lazy<RightArrowHandler>(() => new RightArrowHandler());
            _altCHandler = new Lazy<AltCHandler>(() => new AltCHandler());
            _altVHandler = new Lazy<AltVHandler>(() => new AltVHandler());
            _altXHandler = new Lazy<AltXHandler>(() => new AltXHandler());
            _altIHandler = new Lazy<AltIHandler>(() => new AltIHandler());
            _deleteHandler = new Lazy<DeleteHandler>(() => new DeleteHandler());
            _defaultHandler = new Lazy<DefaultHandler>(() => new DefaultHandler());
        }

        public IKeyHandler DefinePressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            IKeyHandler keyHandler = null;

            if (consoleKeyInfo.Modifiers == ConsoleModifiers.Alt)
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.C:
                        keyHandler = _altCHandler.Value;
                        break;

                    case ConsoleKey.V:
                        keyHandler = _altVHandler.Value;
                        break;

                    case ConsoleKey.X:
                        keyHandler = _altXHandler.Value;
                        break;

                    case ConsoleKey.I:
                        keyHandler = _altIHandler.Value;
                        break;
                }
            }
            else
            {
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        keyHandler = _upArrowHandler.Value;
                        break;

                    case ConsoleKey.DownArrow:
                        keyHandler = _downArrowHandler.Value;
                        break;

                    case ConsoleKey.LeftArrow:
                        keyHandler = _leftArrowHandler.Value;
                        break;

                    case ConsoleKey.RightArrow:
                        keyHandler = _rightArrowHandler.Value;
                        break;

                    case ConsoleKey.Delete:
                        keyHandler = _deleteHandler.Value;
                        break;

                    default:
                        keyHandler = _deleteHandler.Value;
                        break;
                }
            }

            return keyHandler;
        }
    }
}
