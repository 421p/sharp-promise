using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SharpPromise {

    public static class Core {

        public static Task WhenAny(IEnumerable<Task> promises)
        {
            return Task.WhenAny(promises);
        }

        public static Task WhenAny<T>(IEnumerable<Task<T>> promises)
        {
            return Task.WhenAny(promises);
        }

        public static Task WhenAny(Task[] promises)
        {
            return Task.WhenAny(promises);
        }

        public static Task WhenAny<T>(Task<T>[] promises)
        {
            return Task.WhenAny(promises);
        }

        public static Task WhenAll(IEnumerable<Task> promises)
        {
            return Task.WhenAll(promises);
        }

        public static Task WhenAll<T>(IEnumerable<Task<T>> promises)
        {
            return Task.WhenAll(promises);
        }

        public static Task WhenAll(Task[] promises)
        {
            return Task.WhenAll(promises);
        }

        public static Task WhenAll<T>(Task<T>[] promises)
        {
            return Task.WhenAll(promises);
        }

        public static Task<T> When<T>(Func<T> action)
        {
            return Task.Factory.StartNew(action);
        }

        public static Task When(Action action)
        {
            return Task.Factory.StartNew(action);
        }

        public static Task<T> Then<T>(this Task<T> task, Func<Task<T>, T> action)
        {
            return task.ContinueWith(action);
        }

        public static Task Then<T>(this Task<T> task, Action<Task<T>> action)
        {
            return task.ContinueWith(action);
        }

        public static Task Then(this Task task, Action<Task> action)
        {
            return task.ContinueWith(action);
        }

        public static Task<T> Promise<T>(this TaskCompletionSource<T> defer)
        {
            return defer.Task;
        }

        public static void Resolve<T>(this TaskCompletionSource<T> defer, T result)
        {
            defer.SetResult(result);
        }

        public static void Reject<T>(this TaskCompletionSource<T> defer, Exception e)
        {
            defer.SetException(e);
        }

        public static void Reject<T>(this TaskCompletionSource<T> defer, IEnumerable<Exception> e)
        {
            defer.SetException(e);
        }

        public static TaskCompletionSource<T> Deferred<T>()
        {
            return new TaskCompletionSource<T>();
        }
    }
}
