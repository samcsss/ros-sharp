/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2
using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Action;

namespace RosSharp.RosBridgeClient.MessageTypes.ActionTutorialsInterfaces
{
    public class FibonacciActionGoal : ActionGoal<FibonacciGoal>
    {
        public const string RosMessageName = "action_tutorials_interfaces/action/FibonacciActionGoal";

        public FibonacciActionGoal() : base()
        {
            this.args = new FibonacciGoal();
        }

        public FibonacciActionGoal(Header header, GoalInfo goalInfo, FibonacciGoal args) : base(header, goalInfo)
        {
            this.args = args;
        }
    }
}
#endif
