using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilnGod.PlotlyCharts.DemoTest.SchemaReview
{
    public static class SchemaExtensions
    {


		public const string LayoutFileHeader = @"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Layouts
{

";

		public const string FramesFileHeader = @"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Frames
{

";

		public const string ConfigFileHeader = @"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Configuration
{

";

		public const string AnimationFileHeader = @"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Wrappers;
using KilnGod.PlotlyCharts.Enumerations;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Animations
{

";

		public const string TransformsFileHeader =
@"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Transforms
{

";


		public const string CommonFileHeader =
@"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Common
{

";


		public const string TracesFileHeader =
@"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using KilnGod.PlotlyCharts.Common;
using KilnGod.PlotlyCharts.Enumerations;
using KilnGod.PlotlyCharts.Wrappers;
using System.Dynamic;

namespace KilnGod.PlotlyCharts.Traces
{

";

		public const string EnumerationsFileHeader = @"//***********************************************************************************
// KilnGod.PlotlyCharts 
//
// Copyright (c) 2022 James Carpenter (KilnGod)
//
// File: @filename@
//
// This file is part of KilnGod.PlotlyCharts and is distributed under the MIT Open
// Source License. See LICENSE.txt for details.
//***********************************************************************************

using System.ComponentModel;

namespace KilnGod.PlotlyCharts.Enumerations
{

";



    }
}
