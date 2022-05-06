using NUnit.Framework;

namespace PriorityQueue.Tests
{
    [TestFixture]
    internal class FastPriorityQueueTests : SharedFastPriorityQueueTests<FastPriorityQueue<Node>>
    {
        protected override FastPriorityQueue<Node> CreateQueue()
        {
            return new FastPriorityQueue<Node>(100);
        }

        protected override bool IsValidQueue()
        {
            return Queue.IsValidQueue();
        }
    }
}

