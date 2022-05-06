using NUnit.Framework;

namespace PriorityQueue.Tests
{
    [TestFixture]
    internal class StablePriorityQueueTests : SharedFastPriorityQueueTests<StablePriorityQueue<Node>>
    {
        protected override StablePriorityQueue<Node> CreateQueue()
        {
            return new StablePriorityQueue<Node>(100);
        }

        protected override bool IsValidQueue()
        {
            return Queue.IsValidQueue();
        }

        [Test]
        public void TestOrderedQueue()
        {
            SharedStablePriorityQueueTests.TestOrderedQueue(Enqueue, Dequeue);
        }

        [Test]
        public void TestMoreComplicatedOrderedQueue()
        {
            SharedStablePriorityQueueTests.TestMoreComplicatedOrderedQueue(Enqueue, Dequeue);
        }
    }
}

