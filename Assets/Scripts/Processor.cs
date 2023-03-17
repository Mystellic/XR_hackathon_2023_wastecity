using UnityEngine;

public class Processor : MonoBehaviour
{
    public enum ProcessorType 
    {
        Producer, 
        Consumer, 
        Recycler, 
        Waster,
    }


    // Each of the processortypes have their own possible things they can be
    public enum Producers
    {
        Plastic_Bottle_Factory,
        Glass_Bottle_Factory,
        Water_Bottle_Factory,
        Plastic_Factory,
        Glass_Factory,
        Oil_Drill,
        Mineral_Miner,
    }

    public enum Consumers 
    {
        Small_Society,
        Medium_Society,
        Large_Society,
    }

    public enum Recyclers 
    {
        Glass_Recycler,
        Water_Cleaner,
    }

    public enum Wasters
    {
        Landfill,
        Incinerator,
    }



    [HideInInspector] public ProcessorType processType;
    [HideInInspector] public Producers producer;
    [HideInInspector] public Consumers consumer;
    [HideInInspector] public Recyclers recycler;
    [HideInInspector] public Wasters waster;


    public InOutput[] inputs;
    public InOutput[] outputs;
}
