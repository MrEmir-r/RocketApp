using UnityEngine;
interface IRocketInfo
{
    Transform TopLeftF { get; set; }
    Transform TopLeftB { get; set; }
    Transform TopRightF { get; set; }
    Transform TopRightB { get; set; }
    Transform BotLeftF { get; set; }
    Transform BotLeftB { get; set; }
    Transform BotRightF { get; set; }
    Transform BotRightB { get; set; } 
    Transform TopCenter { get; set; }

}