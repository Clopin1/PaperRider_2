using UnityEngine;
using System;
using System.Net.Sockets;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    //tempo de spaw
    public float spawnRate;

    //altura minima
    public float minHeight;

    //altura maxima
    public float maxHeight;


    // invocar obj
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }


    //Sumir obj
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }


    //Vereficar se sumiu
    private void Spawn()
    {
        System.Random rand = new System.Random();
        GameObject ruler = Instantiate(prefab, transform.position, Quaternion.identity);
        ruler.transform.position += Vector3.up * rand.Next((int)minHeight, (int)maxHeight);
        spawnRate = rand.Next(1,10);
        spawnRate /= 10;
    }
}
