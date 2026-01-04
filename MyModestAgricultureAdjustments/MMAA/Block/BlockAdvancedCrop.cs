using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Vintagestory.GameContent;

namespace MyModestAgricultureAdjustments.Block
{
    internal class BlockAdvancedCrop : BlockCrop
    {
        public override void OnServerGameTick(IWorldAccessor world, BlockPos pos, object? extra = null)
        {
            if (extra is Vintagestory.API.Common.Block block) world.BlockAccessor.ExchangeBlock(block.BlockId, pos);
        }
    }
}
