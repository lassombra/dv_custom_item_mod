using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace custom_item_components
{
	public class RotarySpec : MonoBehaviour
	{
		public float rigidbodyMass = 1f;
		public float rigidbodyAngularDrag = 0.03f;
		public float blockAngularDrag;
		[Header("Rotary (knob)")]
		public bool invertDirection;
		public float scrollWheelHoverScroll = 1f;
		public bool scrollWheelUseSpringRotation;
		[Header("Notches")]
		public bool useSteppedJoint = true;
		[Tooltip("only applies if use stepped joint is true")]
		public int notches = 20;
		[Tooltip("only applies if use stepped joint is true")]
		public bool useInnerLimitSpring;
		[Tooltip("applies if use Inner LimitSpring is true")]
		public int innerLimitMinNotch;
		[Tooltip("applies if use Inner LimitSpring is true")]
		public int innerLimitMaxNotch;

		// Token: 0x0400384E RID: 14414
		[Header("Hinge Joint")]
		public Vector3 jointAxis = Vector3.up;
		public bool useSpring = true;
		public float jointSpring = 0.5f;
		public float jointDamper;
		public bool useLimits = true;
		public float jointLimitMin;
		public float jointLimitMax;
		public float bounciness;
		public float bounceMinVelocity;
		[Tooltip("A value between joint min and max limit")]
		public float jointStartingPos;
		[Header("Static non-vr interaction area - optional")]
		public StaticInteractionArea nonVrStaticInteractionArea;

		[Header("Audio")]
		public AudioClip notch;
		public AudioClip drag;
		public AudioClip limitHit;
	}
}
