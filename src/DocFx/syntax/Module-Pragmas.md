---
title: Pragmas Section - Module
description: LambdaSharp module configuration pragmas
keywords: module, pragma, section, configuration, syntax, yaml, cloudformation
---
# Module Pragmas

Pragmas are used to change the default processing behavior of the LambdaSharp CLI. They are generally only required for very specific situations.

|Pragma                                 |Definition                           |
|---------------------------------------|-------------------------------------|
|`no-lambdasharp-dependencies`          |Don't reference LambdaSharp Core resources (DLQ, Logging Stream, etc.)|
|`no-module-registration`               |Don't create a module registration|
|`Overrides`                            |Override default values for built-in declarations|
|`sam-transform`                        |Add SAM template transform to CloudFormation output|

### Overrides Keys
|Key                                         |Definition                                                               |Default                                |
|--------------------------------------------|-------------------------------------------------------------------------|---------------------------------------|
|`Module::DeadLetterQueue`                   |Expression for determining the module dead-letter queue.                 |`!Ref LambdaSharp::DeadLetterQueue`    |
|`Module::LoggingStream`                     |Expression for determining the module logging stream.                    |`!Ref LambdaSharp::LoggingStream`      |
|`Module::LoggingStreamRole`                 |Expression for determining the module logging stream role.               |`!Ref LambdaSharp::LoggingStreamRole`  |
|`Module::LogRetentionInDays`                |Expression for determining the number days log entries are retained for. |`30`                                   |
|`Module::WebSocket.RouteSelectionExpression`|Expression for determining the WebSocket route.                          |`"$request.body.action"`               |
