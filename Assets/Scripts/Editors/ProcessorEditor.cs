using UnityEditor;

[CustomEditor(typeof(Processor))]
public class ProcessorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Processor processor = target as Processor;

        // Initialise the Processor types enumerable
        processor.processType = (Processor.ProcessorType)EditorGUILayout.EnumPopup("Processor Type", processor.processType);

        switch (processor.processType)
        {
            // Show the producer type editor
            case Processor.ProcessorType.Producer:
                ShowProducerEditor(processor);
                break;
            
            // Show the consumer type editor
            case Processor.ProcessorType.Consumer:
                ShowConsumerEditor(processor);
                break;

            // Show the recyler type editor
            case Processor.ProcessorType.Recycler:
                ShowRecyclerEditor(processor);
                break;

            // Show the waster type editor
            case Processor.ProcessorType.Waster:
                ShowWasterEditor(processor);
                break;

        }

        DrawDefaultInspector();
    }

    private void ShowProducerEditor(Processor processor)
    {
        processor.producer = (Processor.Producers)EditorGUILayout.EnumPopup("Type of Producer", processor.producer);
    }

    private void ShowConsumerEditor(Processor processor)
    {
        processor.consumer = (Processor.Consumers)EditorGUILayout.EnumPopup("Type of Consumer", processor.consumer);
    }

    private void ShowRecyclerEditor(Processor processor)
    {
        processor.recycler = (Processor.Recyclers)EditorGUILayout.EnumPopup("Type of Recycler", processor.recycler);
    }

    private void ShowWasterEditor(Processor processor)
    {
        processor.waster = (Processor.Wasters)EditorGUILayout.EnumPopup("Type of Waster", processor.waster);
    }


}


