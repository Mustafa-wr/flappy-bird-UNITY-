using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawn : MonoBehaviour
{
	[SerializeField] private float _maxTime = 1.5f;
	[SerializeField] private float _height_range = 0.45f;
	[SerializeField] private GameObject _pipe;

	private float _timer;

	private void Start()
	{
		spawn_pipe();
	}

	private void Update()
	{
		if (_timer > _maxTime)
		{
			spawn_pipe();
			_timer = 0;
		}

		_timer += Time.deltaTime;
	}

	private void spawn_pipe()
	{
		Vector3 spawn_position = transform.position + new Vector3(0, Random.Range(-_height_range, _height_range));
		GameObject pipe = Instantiate(_pipe, spawn_position, Quaternion.identity);
		Destroy(pipe, 10f);
	}
}
