/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;
using RosSharp.RosBridgeClient.MessageTypes.Octomap;

namespace RosSharp.RosBridgeClient.MessageTypes.Octomap
{
    public class OctomapWithPose : Message
    {
        public const string RosMessageName = "octomap_msgs/OctomapWithPose";

        //  A 3D map in binary format, as Octree
        public Header header { get; set; }
        //  The pose of the octree with respect to the header frame 
        public Pose origin { get; set; }
        //  The actual octree msg
        public Octomap octomap { get; set; }

        public OctomapWithPose()
        {
            this.header = new Header();
            this.origin = new Pose();
            this.octomap = new Octomap();
        }

        public OctomapWithPose(Header header, Pose origin, Octomap octomap)
        {
            this.header = header;
            this.origin = origin;
            this.octomap = octomap;
        }
    }
}
