/*You are developing a program to manage a call queue of customers using the Queue in C#. 
The program creates a queue of callers and demonstrates the functionality of enqueueing 
elements into the queue and iterating over the elements and dequeuing.

Use linked lists.
*/

namespace Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime? AnswerTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Consultant { get; set; }
    }
    public class CallCenter
    {
        private int _counter = 0;

        public Queue<IncomingCall> Calls { get; private set; }

        public CallCenter() => Calls = new Queue<IncomingCall>();

        public IncomingCall Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            };
            Calls.Enqueue(call);
            return call;
        }
        public IncomingCall? AnswerCall(string consultant)
        {
            if (!AreWaitingCalls()) { return null; }
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.AnswerTime = DateTime.Now;
                return call;
            }
        }
        public void EndCall(IncomingCall call) => call.EndTime = DateTime.Now;

        public bool AreWaitingCalls() => Calls.Count > 0;
    }
}
