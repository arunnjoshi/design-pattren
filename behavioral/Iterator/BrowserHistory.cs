using System.Collections;

namespace Iterator
{
    public class BrowserHistory
    {
        private readonly string[] urls = new string[3];
        private int i = 0;
        public void Push(string url)
        {
            urls[i] = url;
            i++;
        }

        public string Pop()
        {
            var url = urls[i];
            urls[i] = "";
            return url;
        }

        public IIterator CreateIterator()
        {
            return new ArrayIterator(this);
        }



        class ListIterator : IIterator
        {
            private readonly BrowserHistory history;
            private int index;

            public ListIterator(BrowserHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls.ElementAt(index);
            }

            public bool HasNext()
            {
                return index < history.urls.Count();
            }

            public void Next()
            {
                index++;
            }
        }

        class ArrayIterator : IIterator
        {
            private readonly BrowserHistory history;
            private int index;

            public ArrayIterator(BrowserHistory history)
            {
                this.history = history;
            }

            public string Current()
            {
                return history.urls.ElementAt(index);
            }

            public bool HasNext()
            {
                return index < history.i;
            }

            public void Next()
            {
                index++;
            }
        }
    }
}