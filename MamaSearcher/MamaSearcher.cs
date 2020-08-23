using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    class MamaSearcher : IMamaSearcher
    {
        private Dictionary<string, Action<int, string>> _patternToAction;
        public MamaSearcher()
        {
            _patternToAction = new Dictionary<string, Action<int, string>>();
        }
        public void PerformSearch(string content)
        {
            if (_patternToAction.Count == 0)
            {
                return;
            }
            foreach (var pair in _patternToAction)
            {
                int index = content.IndexOf(pair.Key);
                if (index != -1)
                {
                    pair.Value.Invoke(index, content);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if (!String.IsNullOrWhiteSpace(pattern) && actionToPerform != null)
                _patternToAction.Add(pattern, actionToPerform);
        }
    }
}
