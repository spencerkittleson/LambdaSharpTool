/*
 * MindTouch λ#
 * Copyright (C) 2018 MindTouch, Inc.
 * www.mindtouch.com  oss@mindtouch.com
 *
 * For community documentation and downloads visit mindtouch.com;
 * please review the licensing section.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace MindTouch.LambdaSharp.Tool.Model {

    public abstract class AOutput {

        //--- Properties ---
        public string Description { get; set; }
    }

    public class ExportOutput : AOutput {

        //--- Properties ---
        public string Name { get; set; }
        public object Value { get; set; }
    }

    public class CustomResourceHandlerOutput : AOutput {

        //--- Properties ---
        public string CustomResourceName { get; set; }
        public string Handler { get; set; }
    }

    public class MacroOutput : AOutput {

        //--- Properties ---
        public string Macro { get; set; }
        public string Handler { get; set; }
    }
}