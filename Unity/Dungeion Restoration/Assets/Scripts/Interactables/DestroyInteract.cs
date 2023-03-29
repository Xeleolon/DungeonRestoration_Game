using UnityEngine;

public class DestroyInteract : Interactable
{
    public override void Interact()
    {
        base.Interact();
        if (interactionState == 2)
        {
            string message = new string(gameObject.name + " Destoryed");
            Debug.Log(message);
            PlayerChat.instance.NewMessage(message);
            interacted = true;
            Destroy(gameObject);
        }
        else
        {
            string message = new string("Beep Boop Bop");
            Debug.Log(message);
            PlayerChat.instance.NewMessage(message);
        }
    }

}