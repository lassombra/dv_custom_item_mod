using custom_item_components;
using DV.CabControls.Spec;
using UnityEngine;

namespace custom_item_mod
{
	internal class CustomControlsMap
	{
		internal static void Map(DV.Customization.Gadgets.GadgetBase gadget)
		{
			var rotaries = gadget.GetComponentsInChildren<RotarySpec>();
			foreach (var rotary in rotaries)
			{
				var dvRotary = rotary.gameObject.AddComponent<Rotary>();
				CopySettings(rotary, ref dvRotary);
				rotary.gameObject.SetLayerIncludingChildren((int)DV.Layers.DVLayer.Inventory);
				Object.Destroy(rotary);		
			}
		}

		private static void CopySettings(RotarySpec rotary, ref Rotary dvRotary)
		{
			dvRotary.rigidbodyMass = rotary.rigidbodyMass;
			dvRotary.rigidbodyAngularDrag  = rotary.rigidbodyAngularDrag ;
			dvRotary.blockAngularDrag = rotary.blockAngularDrag;
			dvRotary.invertDirection = rotary.invertDirection;
			dvRotary.scrollWheelHoverScroll  = rotary.scrollWheelHoverScroll ;
			dvRotary.scrollWheelUseSpringRotation = rotary.scrollWheelUseSpringRotation;
			dvRotary.useSteppedJoint  = rotary.useSteppedJoint;
			dvRotary.notches  = rotary.notches;
			dvRotary.useInnerLimitSpring = rotary.useInnerLimitSpring;
			dvRotary.innerLimitMinNotch = rotary.innerLimitMinNotch;
			dvRotary.innerLimitMaxNotch = rotary.innerLimitMaxNotch;
			dvRotary.jointAxis  = rotary.jointAxis;
			dvRotary.useSpring  = rotary.useSpring;
			dvRotary.jointSpring  = rotary.jointSpring;
			dvRotary.jointDamper = rotary.jointDamper;
			dvRotary.useLimits  = rotary.useLimits;
			dvRotary.jointLimitMin = rotary.jointLimitMin;
			dvRotary.jointLimitMax = rotary.jointLimitMax;
			dvRotary.bounciness = rotary.bounciness;
			dvRotary.bounceMinVelocity = rotary.bounceMinVelocity;
			dvRotary.jointStartingPos = rotary.jointStartingPos;
			dvRotary.notch = rotary.notch;
			dvRotary.drag = rotary.drag;
			dvRotary.limitHit = rotary.limitHit;
			dvRotary.nonVrStaticInteractionArea = ReplaceNonVrStaticInteractionArea(rotary);
		}

		private static DV.Interaction.StaticInteractionArea ReplaceNonVrStaticInteractionArea(RotarySpec rotary)
		{
			var interactionArea = rotary.nonVrStaticInteractionArea?.gameObject.AddComponent<DV.Interaction.StaticInteractionArea>();
			if (interactionArea != null)
			{
				Object.Destroy(rotary.nonVrStaticInteractionArea);
			}
			return interactionArea;
		}
	}
}