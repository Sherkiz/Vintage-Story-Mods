using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using MyModestAgricultureAdjustments.Block;
using MyModestAgricultureAdjustments.BlockEntity;


namespace MyModestAgricultureAdjustments
{ 
    public class MyModestAgriAdSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + api.Side);
            api.RegisterBlockClass(Mod.Info.ModID + ".churn", typeof(BlockChurn));
            api.RegisterBlockEntityClass(Mod.Info.ModID + "churnEntity", typeof(BlockEntityChurn));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("mymodestagriad:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("mymodestagriad:hello"));
        }

    }
}
