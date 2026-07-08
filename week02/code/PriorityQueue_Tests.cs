using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 items with different priorities and dequeue once.
    // Expected Result: The item with the highest priority should be returned (The last item).
    // Defect(s) Found: The last item is not checked in the queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 1);
        priorityQueue.Enqueue("b", 4);
        priorityQueue.Enqueue("c", 7);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("c", result);

    }

    [TestMethod]
    // Scenario: We will try to dequeue from an empty priority queue.
    // Expected Result: InvalidOperationException should be throw with the message "The queue is empty."
    // Defect(s) Found: No defect found.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException message)
        {
            Assert.AreEqual("The queue is empty.", message.Message);
        }

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Add 3 items with different priorities and dequeue once.
    // Expected Result: The item with the highest priority should be returned (The second item).
    // Defect(s) Found: No defect found
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 3);
        priorityQueue.Enqueue("b", 7);
        priorityQueue.Enqueue("c", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("b", result);

    }

    [TestMethod]
    // Scenario: Add 4 items. Two of them have the same priority.
    // Expected Result: The first item with the highest priority should be returned (In this case should be the second).
    // Defect(s) Found: The original code used >=, so it returned the later item with the same priority instead of the first. In this case, it shuld return and remove de second item.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 3);
        priorityQueue.Enqueue("b", 7);
        priorityQueue.Enqueue("c", 7);
        priorityQueue.Enqueue("m", 6);

        var result = priorityQueue.Dequeue();
        Console.WriteLine(result);
        Assert.AreEqual("b", result);

    }


    [TestMethod]
    // Scenario: Add 3 items. Call Dequeue thrice.
    // Expected Result: First call return the highest priority. Second call should return the second item with highest priority. Third call should return the remainig item.
    // Defect(s) Found: The item with the highest item was returned but not removed from the queue.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 9);
        priorityQueue.Enqueue("b", 7);
        priorityQueue.Enqueue("c", 6);


        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();
        var third = priorityQueue.Dequeue();
        Assert.AreEqual("a", first);
        Assert.AreEqual("b", second);
        Assert.AreEqual("c", third);

    }
}