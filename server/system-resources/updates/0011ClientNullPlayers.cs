'From Croquet1.0beta of 11 April 2006 [latest update: #1] on 22 March 2010 at 9:22:46 am'!!QwaqAudioSession class methodsFor: 'primitives' stamp: 'eem 3/18/2010 17:42'!primGetPluginVerbosityOrNil	"For quick determination of the plugin being present"	<primitive: 'primitiveGetLogVerbosity' module: 'QAudioPlugin'>	^nil! !!QwaqAudioSession class methodsFor: 'utility' stamp: 'eem 3/18/2010 17:44'!hasQAudioPlugin	^self primGetPluginVerbosityOrNil ~~ nil! !!QwaqVideoSession class methodsFor: 'primitives' stamp: 'eem 3/18/2010 17:47'!primGetPluginVerbosityOrNil	"For quick determination of the plugin being present"	<primitive: 'primitiveGetLogVerbosity' module: 'QVideoCodecPluginMC'>	^nil! !!QwaqVideoSession class methodsFor: 'utility' stamp: 'eem 3/18/2010 17:48'!hasQVideoCodecPlugin	^self primGetPluginVerbosityOrNil ~~ nil! !!QNetVidClient methodsFor: 'defaults' stamp: 'eem 3/18/2010 17:45'!createAudioPlayerOutput	"Subclasses may override."	^QwaqAudioSession hasQAudioPlugin		ifTrue: [QNetVidAudioTrackDecoder new]		ifFalse: [QNetVidNullPlayerOutput new]! !!QNetVidClient methodsFor: 'defaults' stamp: 'eem 3/18/2010 17:50'!createVideoPlayerOutput	"Subclasses may override."	^QwaqVideoSession hasQVideoCodecPlugin		ifTrue: [QNetVidVideoTrackDecoder new]		ifFalse: [QNetVidNullPlayerOutput new]! !