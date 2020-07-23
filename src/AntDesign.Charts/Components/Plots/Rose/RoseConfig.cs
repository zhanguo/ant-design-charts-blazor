using OneOf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AntDesign.Charts
{
    public class RoseConfig : IRoseViewConfig, IPlotConfig
    {
        [JsonPropertyName("radiusField")]
        public string RadiusField { get; set; }
        [JsonPropertyName("categoryField")]
        public string CategoryField { get; set; }
        [JsonPropertyName("colorField")]
        public string ColorField { get; set; }
        [JsonPropertyName("radius")]
        public double? Radius { get; set; }
        [JsonPropertyName("innerRadius")]
        public double? InnerRadius { get; set; }
        [JsonPropertyName("sectorStyle")]
        public GraphicStyle SectorStyle { get; set; }
        [JsonPropertyName("label")]
        public RoseLabel Label { get; set; }
        [JsonPropertyName("renderer")]
        public string Renderer { get; set; }
        [JsonPropertyName("data")]
        public object Data { get; set; }
        [JsonPropertyName("meta")]
        public object Meta { get; set; }
        [JsonPropertyName("padding")]
        public string Padding { get; set; }
        [JsonPropertyName("xField")]
        public string XField { get; set; }
        [JsonPropertyName("yField")]
        public string YField { get; set; }
        [JsonPropertyName("color")]
        public string[] Color { get; set; }
        [JsonPropertyName("xAxis")]
        public Axis XAxis { get; set; }
        [JsonPropertyName("yAxis")]
        public Axis YAxis { get; set; }
        [JsonPropertyName("tooltip")]
        public Tooltip Tooltip { get; set; }
        [JsonPropertyName("legend")]
        public Legend Legend { get; set; }
        [JsonPropertyName("animation")]
        public object Animation { get; set; }
        [JsonIgnore]
        public OneOf<string, object> Theme { get; set; }
        [JsonPropertyName("theme")]
        public object themeMapping => Theme.Value;
        [JsonPropertyName("responsiveTheme")]
        public object ResponsiveTheme { get; set; }
        [JsonPropertyName("interactions")]
        public Interaction[] Interactions { get; set; }
        [JsonPropertyName("responsive")]
        public bool? Responsive { get; set; }
        [JsonPropertyName("title")]
        public Title Title { get; set; }
        [JsonPropertyName("description")]
        public Description Description { get; set; }
        [JsonPropertyName("guideLine")]
        public GuideLineConfig[] GuideLine { get; set; }
        [JsonPropertyName("defaultState")]
        public ViewConfigDefaultState DefaultState { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("forceFit")]
        public bool? ForceFit { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("pixelRatio")]
        public int? PixelRatio { get; set; }
        [JsonPropertyName("localRefresh")]
        public bool? LocalRefresh { get; set; }
        Label IViewConfig.Label { get; set; }
    }

    public interface IRoseViewConfig : IViewConfig
    {
        [JsonPropertyName("radiusField")]
        public string RadiusField { get; set; }
        [JsonPropertyName("categoryField")]
        public string CategoryField { get; set; }
        [JsonPropertyName("colorField")]
        public string ColorField { get; set; }
        [JsonPropertyName("radius")]
        public double? Radius { get; set; }
        [JsonPropertyName("innerRadius")]
        public double? InnerRadius { get; set; }
        /// <summary>
        ///  每个扇形切片的样式 
        /// </summary>
        [JsonPropertyName("sectorStyle")]
        public GraphicStyle SectorStyle { get; set; }//OneOf<GraphicStyle, ((...args: any[]) => GraphicStyle)>
        [JsonPropertyName("label")]
        public RoseLabel Label { get; set; }
    }

    public interface IRoseLabel : ILabel
    {
        /// <summary>
        /// 'outer','inner'
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }// OneOfn<'outer','inner'>
        public static string TypeOuter = "outer";
        public static string TypeInner = "inner";

        /// <summary>
        ///  自动调整颜色 
        /// </summary>
        [JsonPropertyName("adjustColor")]
        public bool? AdjustColor { get; set; }
        /// <summary>
        ///  自动旋转 
        /// </summary>
        [JsonPropertyName("autoRotate")]
        public bool? AutoRotate { get; set; }

        /// <summary>
        /// label的内容，如果不配置，读取scale中的第一个field对应的值  G2 4.0 就这样实现的
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }//string | ((...args: any[]) => string);
    }
    public class RoseLabel : IRoseLabel
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("adjustColor")]
        public bool? AdjustColor { get; set; }
        [JsonPropertyName("autoRotate")]
        public bool? AutoRotate { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
        [JsonPropertyName("visible")]
        public bool? Visible { get; set; }
        [JsonPropertyName("precision")]
        public int? Precision { get; set; }
        [JsonPropertyName("suffix")]
        public string Suffix { get; set; }
        [JsonPropertyName("style")]
        public TextStyle Style { get; set; }
        [JsonPropertyName("offset")]
        public int? Offset { get; set; }
        [JsonPropertyName("offsetX")]
        public int? OffsetX { get; set; }
        [JsonPropertyName("offsetY")]
        public int? OffsetY { get; set; }
        [JsonPropertyName("position")]
        public string Position { get; set; }
        [JsonPropertyName("adjustPosition")]
        public bool? AdjustPosition { get; set; }
        [JsonPropertyName("field")]
        public string Field { get; set; }
    }
}

