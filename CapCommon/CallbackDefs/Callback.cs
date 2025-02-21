namespace CallbackDefs
{
	public delegate void Callback();
	public delegate void Callback<T>(T p_param);
	public delegate void Callback<T1, T2>(T1 p_param1, T2 p_param2);
	public delegate void Callback<T1, T2, T3>(T1 p_param1, T2 p_param2, T3 p_param3);
	public delegate void Callback<T1, T2, T3, T4>(T1 p_param1, T2 p_param2, T3 p_param3, T4 p_param4);
	public delegate void Callback<T1, T2, T3, T4, T5>(T1 p_param1, T2 p_param2, T3 p_param3, T4 p_param4, T5 p_param5);
}
