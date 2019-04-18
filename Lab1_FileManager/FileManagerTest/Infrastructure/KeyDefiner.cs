using FileManagerTest.Abstraction;
using FileManagerTest.KeyHandlers;
using System;
using System.Collections.Generic;

namespace FileManagerTest.Infrastructure
{
    public class KeyDefiner
    {
        private Dictionary<ConsoleKey, IKeyHandler> _keyHandlers;
        private DefaultHandler _defaultHandler;

        public KeyDefiner()
        {
            _keyHandlers = new Dictionary<ConsoleKey, IKeyHandler>();
        }

        public IKeyHandler DefinePressedKey(ConsoleKeyInfo consoleKeyInfo)
        {
            IKeyHandler keyHandler = null;

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow: 
                    if (!_keyHandlers.ContainsKey(ConsoleKey.UpArrow))
                    {
                        _keyHandlers[ConsoleKey.UpArrow] = new UpArrowHandler();
                    }
                    keyHandler = _keyHandlers[ConsoleKey.UpArrow];
                    break;

                case ConsoleKey.DownArrow:
                    if (!_keyHandlers.ContainsKey(ConsoleKey.DownArrow))
                    {
                        _keyHandlers[ConsoleKey.DownArrow] = new DownArrowHandler();
                    }
                    keyHandler = _keyHandlers[ConsoleKey.DownArrow];
                    break;

                case ConsoleKey.LeftArrow:
                    if (!_keyHandlers.ContainsKey(ConsoleKey.LeftArrow))
                    {
                        _keyHandlers[ConsoleKey.LeftArrow] = new LeftArrowHandler();
                    }
                    keyHandler = _keyHandlers[ConsoleKey.LeftArrow];
                    break;

                case ConsoleKey.RightArrow:
                    if (!_keyHandlers.ContainsKey(ConsoleKey.RightArrow))
                    {
                        _keyHandlers[ConsoleKey.RightArrow] = new RightArrowHandler();
                    }
                    keyHandler = _keyHandlers[ConsoleKey.RightArrow];
                    break;

                case ConsoleKey.C:
                    if (consoleKeyInfo.Modifiers == ConsoleModifiers.Alt)
                    {
                        if (!_keyHandlers.ContainsKey(ConsoleKey.C))
                        {
                            _keyHandlers[ConsoleKey.C] = new AltCHandler();
                        }
                        keyHandler = _keyHandlers[ConsoleKey.C];
                    }
                    break;

                case ConsoleKey.V:
                    if (consoleKeyInfo.Modifiers == ConsoleModifiers.Alt)
                    {
                        if (!_keyHandlers.ContainsKey(ConsoleKey.V))
                        {
                            _keyHandlers[ConsoleKey.V] = new AltVHandler();
                        }
                        keyHandler = _keyHandlers[ConsoleKey.V];
                    }
                    break;

                case ConsoleKey.X:
                    if (consoleKeyInfo.Modifiers == ConsoleModifiers.Alt)
                    {
                        if (!_keyHandlers.ContainsKey(ConsoleKey.X))
                        {
                            _keyHandlers[ConsoleKey.X] = new AltXHandler();
                        }
                        keyHandler = _keyHandlers[ConsoleKey.X];
                    }
                    break;

                case ConsoleKey.I:
                    if (consoleKeyInfo.Modifiers == ConsoleModifiers.Alt)
                    {
                        if (!_keyHandlers.ContainsKey(ConsoleKey.I))
                        {
                            _keyHandlers[ConsoleKey.I] = new AltIHandler();
                        }
                        keyHandler = _keyHandlers[ConsoleKey.I];
                    }
                    break;

                case ConsoleKey.Delete:
                    if (!_keyHandlers.ContainsKey(ConsoleKey.Delete))
                    {
                        _keyHandlers[ConsoleKey.Delete] = new DeleteHandler();
                    }
                    keyHandler = _keyHandlers[ConsoleKey.Delete];
                    break;

                default: 
                    if (_defaultHandler == null)
                    {
                        _defaultHandler = new DefaultHandler();
                    }
                    keyHandler = _defaultHandler;
                    break;
            }

            if (keyHandler == null)
            {
                if (_defaultHandler == null)
                {
                    _defaultHandler = new DefaultHandler();
                }
                keyHandler = _defaultHandler;
            }

            return keyHandler;
        }
    }
}
