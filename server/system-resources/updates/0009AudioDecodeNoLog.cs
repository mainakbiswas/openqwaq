'From Croquet1.0beta of 11 April 2006 [latest update: #1] on 7 April 2010 at 5:07:49 pm'!!QAudioDecoder methodsFor: 'primitives' stamp: 'jcg 3/26/2010 19:00'!primDecode: hndl input: bytes count: inputSize offset: inputOffset into: aSoundBuffer offset: outputOffset flags: flags	<primitive: 'primitiveAudioDecode' module: 'QAudioPlugin'>	self primitiveFailed! !!QAudioDecoder methodsFor: 'decoding' stamp: 'eem 4/8/2010 11:24'!decode: inputBytes offset: inputOffset into: buf "a SoundBuffer"	"this version guards against zero sized output buf but doesn't log"	buf size > 0 ifTrue:		[self 			primDecode: handle 			input: inputBytes 			count: inputBytes size - inputOffset 			offset: inputOffset 			into: buf 			offset: 0 			flags: 0]! !