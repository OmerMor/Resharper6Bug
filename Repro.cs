using System;
using System.Reactive.Linq;

namespace Resharper6Bug
{
    public class Repro
    {
        public void Foo()
        {
            IObservable<int> source = null;

            // Type the following, character by character:
            //
            //    source.Select(
            //

            //
            // When entering the '(' character (or when letting R# auto-complete), 
            // R# will reformat the statement to static method invocation:
            //
            //    Observable.Select(source)
            //
        }
    }
}
